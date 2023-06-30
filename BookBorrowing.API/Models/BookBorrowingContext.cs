﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookBorrowing.API.Models
{
    public partial class BookBorrowingContext : DbContext
    {
        public BookBorrowingContext()
        {
        }

        public BookBorrowingContext(DbContextOptions<BookBorrowingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Borrowing> Borrowing { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ViewBorrowing> ViewBorrowing { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.IdBook)
                    .HasName("PK_Book_1");

                entity.Property(e => e.AuthorName).IsFixedLength();

                entity.Property(e => e.BookEdition).IsFixedLength();

                entity.Property(e => e.BookName).IsFixedLength();

                entity.Property(e => e.PublisherName).IsFixedLength();
            });

            modelBuilder.Entity<Borrowing>(entity =>
            {
                entity.HasKey(e => e.IdBorrowing)
                    .HasName("PK_Borrowing_1");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK_Client_1");

                entity.Property(e => e.Adress).IsFixedLength();

                entity.Property(e => e.CellNumber).IsFixedLength();

                entity.Property(e => e.City).IsFixedLength();

                entity.Property(e => e.ClientCpf).IsFixedLength();

                entity.Property(e => e.ClientName).IsFixedLength();
            });

            modelBuilder.Entity<ViewBorrowing>(entity =>
            {
                entity.ToView("ViewBorrowing");

                entity.Property(e => e.BookName).IsFixedLength();

                entity.Property(e => e.ClientCpf).IsFixedLength();

                entity.Property(e => e.ClientName).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}