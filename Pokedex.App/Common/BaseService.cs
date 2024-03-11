﻿using Pokedex.App.Abstract;
using Pokedex.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public int GetLastId() {

            int lastId;
            if (Items.Any())
            {
                lastId = Items.OrderBy(p => p.Id).LastOrDefault().Id;
            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }

        public BaseService() { 
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            Items.Add(item);
        }

        public List<T> GetAllItems()
        {
            return Items; 
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item);
        }

        public void UpdateItems(T item)
        {
            var entity = Items.FirstOrDefault(p => p.Id == item.Id);
            if (entity != null)
            {
                entity = item;
            }            
        }
      
    }
}
