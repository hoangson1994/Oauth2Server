﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oauth2Server.Models;

namespace Oauth2Server.Migrations
{
    [DbContext(typeof(Oauth2ServerContext))]
    [Migration("20181107012951_AddAccount")]
    partial class AddAccount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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