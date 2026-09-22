using Microsoft.EntityFrameworkCore;
using MiTiendaPos.Data;
using MiTiendaPos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiTiendaPos.Services
{
    internal class CategoriaService
    {
        public List<Categoria> Listar(String filtros = "")
        {
            using var ctx = new MiTiendaPosContext();
            IQueryable<Categoria> consulta = ctx.Categorias.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(filtros))
            {
                consulta = consulta.Where(c => c.Nombre.Contains(filtros.Trim()));
            }
            return consulta.OrderBy(c => c.Nombre).ToList();
        }

        //READ
        public Categoria? ObtenerPorId(int id)
        {
            using var ctx = new MiTiendaPosContext();
            return ctx.Categorias.Find(id);
        }

        //CREATE
        public void Crear(Categoria categoria)
        {
            using var ctx = new MiTiendaPosContext();
            Validar(ctx, categoria);
            ctx.Categorias.Add(categoria); 
            ctx.SaveChanges();
        }

        //UPDATE
        public void Actualizar(Categoria categoria)
        {
            using var ctx = new MiTiendaPosContext();
            Categoria existente = ctx.Categorias.Find(categoria.Id)
                ?? throw new InvalidOperationException("La categoría ya no existe.");
            Validar(ctx, categoria);
            existente.Nombre = categoria.Nombre;
            ctx.SaveChanges();
        }

        //DELETE
        public void Eliminar(int id)
        {
            using var ctx = new MiTiendaPosContext();
            Categoria categoria = ctx.Categorias.Find(id)
                ?? throw new InvalidOperationException("La categoría ya no existe.");
            //Validamos si ya tiene productos asociados
            if(ctx.Productos.Any(p=> p.CategoriaId == id))
                throw new InvalidOperationException("No se puede eliminar, esta categoría tiene productos asociados.");

            ctx.Categorias.Remove(categoria);
            ctx.SaveChanges();
        }

        //REGLAS NEGOCIO
        private static void Validar(MiTiendaPosContext ctx, Categoria categoria)
        {
            if (String.IsNullOrWhiteSpace(categoria.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            categoria.Nombre = categoria.Nombre.Trim();
            bool duplicado = ctx.Categorias.Any(c => c.Nombre == categoria.Nombre
            && c.Id == categoria.Id);

            if (duplicado)
                throw new InvalidOperationException("Ya existe una categoria con ese nombre");



        }
    }
}