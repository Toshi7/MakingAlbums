using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20170511062855_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<string>("Genre");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("ID");

                    b.ToTable("Album");
                });
        }
    }
}
