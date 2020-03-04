﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.Cep)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(10);

            //builder.HasOne(p=> p.Usuario)

            builder.HasOne(p => p.FormaPagamento);

        }
    }
}
