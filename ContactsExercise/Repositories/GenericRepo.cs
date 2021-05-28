﻿using ContactsExercise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseModel
    {
        protected AppContext _context;

        public GenericRepo(AppContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEntityAsync(T entity)
        {
            _context.Attach(entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEntityAsync(T entity)
        {
            _context.Attach(entity);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<IList<T>> GetEntitiesAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetEntityAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> EntityExistsAsync(int id)
        {
            return await _context.Set<T>().AnyAsync(x => x.Id == id);
        }
    }
}