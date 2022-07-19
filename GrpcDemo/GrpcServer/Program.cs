using System.Text;

namespace GrpcServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //����
            //����Grpc
            builder.Services.AddGrpc();
            builder.Services.AddMagicOnion();

            var app = builder.Build();
            //����
            app.UseRouting();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            //����
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapMagicOnionService();

                endpoints.MapGet("/", async context =>
                {
                    context.Response.ContentType = "text/plain; charset=utf-8"; 
                    await context.Response.WriteAsync("Grpc������Ѿ��������ȴ�Grpc�ͻ�������!");
                });
            });

            app.Run();
        }
    }
}