﻿using Microsoft.EntityFrameworkCore;
using new_testapp.Data.Base;
using new_testapp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_testapp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        //private readonly AppDbContext _context;

        public ActorsService(AppDbContext context):base(context){
            //_context = context;
        }

        //public async Task AddAsync(Actor actor)
        //{
        //    await _context.Actors.AddAsync(actor);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result=await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
        //    _context.Actors.Remove(result);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Actor>> GetAllAsync()
        //{
        //    var result = await _context.Actors.ToListAsync();
        //    return result;
        //}

        //public async Task<Actor> GetByIdAsync (int id)
        //{
        //    var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //    return result;
        //}

        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    _context.Update(newActor);
        //    await _context.SaveChangesAsync(); 
        //    return newActor;
        //}
    }
}
