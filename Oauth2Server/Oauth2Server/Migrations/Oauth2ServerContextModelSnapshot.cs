﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oauth2Server.Models;

namespace Oauth2Server.Migrations
{
    [DbContext(typeof(Oauth2ServerContext))]
    partial class Oauth2ServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Oauth2Server.Models.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Salt");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAd");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Oauth2Server.Models.Credential", b =>
                {
                    b.Property<string>("AccessToken")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AccountId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("ExpiredAt");

                    b.Property<string>("RefreshToken");

                    b.Property<string>("Scope");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("AccessToken");

                    b.ToTable("Credential");
                });

            modelBuilder.Entity("Oauth2Server.Models.RegisteredClient", b =>
                {
                    b.Property<string>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientDomain");

                    b.Property<string>("ClientIcon");

                    b.Property<string>("ClientName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("RedirectUrl");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAd");

                    b.HasKey("ClientId");

                    b.ToTable("RegisteredClient");
                });
#pragma warning restore 612, 618
        }
    }
}
