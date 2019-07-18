using MongoDB.Driver;
using SacramentPlanner.Models;
using System;
using System.Collections.Generic;

namespace SacramentPlanner.Services
{
    public class AgendaService
    {
        private readonly IMongoCollection<Agenda> _agendas;

        public AgendaService( ISacramentPlannerDatabaseSettings settings )
        {
            MongoClient client = new MongoClient( settings.ConnectionString );
            IMongoDatabase database = client.GetDatabase( settings.DatabaseName );
            _agendas = database.GetCollection<Agenda>( settings.AgendaCollectionName );
        }

        public List<Agenda> Get() =>
            _agendas.Find( book => true ).ToList();

        public Agenda Get( string id ) =>
            _agendas.Find( Agenda => Agenda.AgendaId == id ).FirstOrDefault();

        public Agenda Create( Agenda agenda )
        {
            _agendas.InsertOne( agenda );
            return agenda;
        }

        public void Update( string id, Agenda agendaIn ) =>
            _agendas.ReplaceOne( agenda => agenda.AgendaId == id, agendaIn );

        public void Remove( Agenda agendaIn ) =>
            _agendas.DeleteOne( agenda => agenda.AgendaId == agendaIn.AgendaId );

        public void Remove( string id ) =>
            _agendas.DeleteOne( agenda => agenda.AgendaId == id );

    }
}
