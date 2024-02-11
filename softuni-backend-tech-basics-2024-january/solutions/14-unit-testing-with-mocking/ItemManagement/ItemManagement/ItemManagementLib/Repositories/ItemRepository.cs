using ItemManagementLib.Data;
using ItemManagementLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ItemManagementLib.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public Item GetItemById(int id)
        {
            // Find an item by ID and return it
            return _context.Items.Find(id);
        }

        public IEnumerable<Item> GetAllItems()
        {
            // Get all items and return them
            return _context.Items.ToList();
        }

        public void AddItem(Item item)
        {
            // Add a new item to the database
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (string.IsNullOrWhiteSpace(item.Name) || item.Name.Length > 10)
                throw new ArgumentException("Item name must be between 1 and 10 characters.");

            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            // Update an existing item
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (string.IsNullOrWhiteSpace(item.Name) || item.Name.Length > 10)
                throw new ArgumentException("Item name must be between 1 and 10 characters.");

            _context.Items.Update(item);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            // Delete an item by ID
            var item = _context.Items.Find(id);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}