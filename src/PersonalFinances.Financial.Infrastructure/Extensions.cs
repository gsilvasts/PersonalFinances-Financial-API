using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;
using PersonalFinances.Financial.Infrastructure.Persistence;
using PersonalFinances.Financial.Infrastructure.Persistence.Repositories;

namespace PersonalFinances.Financial.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IExpenseRepository, ExpenseRepository>();

            return services;
        }

        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton(s =>
            {
                var configuration = s.GetService<IConfiguration>();
                var options = new MongoDbOptions();

                configuration.GetSection("Mongo").Bind(options);

                return options;
            });

            services.AddSingleton<IMongoClient>(sp =>
            {
                var options = sp.GetService<MongoDbOptions>();

                return new MongoClient(options.ConnectionString);
            });

            services.AddTransient(sp =>
            {
                //BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;
                BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));

                var options = sp.GetService<MongoDbOptions>();
                var mongoClient = sp.GetService<IMongoClient>();

                return mongoClient.GetDatabase(options.Database);
            });

            return services;
        }
    }
}
