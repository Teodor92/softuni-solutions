using ItemManagementLib.Models;
using ItemManagementLib.Repositories;
using System.Collections.Generic;

namespace ItemManagementApp.Services
{
    public class ItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void AddItem(string name)
        {
            var item = new Item { Name = name };
            _itemRepository.AddItem(item);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _itemRepository.GetAllItems();
        }

        public Item GetItemById(int id)
        {
            return _itemRepository.GetItemById(id);
        }

        public void UpdateItem(int id, string newName)
        {
            var item = _itemRepository.GetItemById(id);
            if (item != null)
            {
                item.Name = newName;
                _itemRepository.UpdateItem(item);
            }
        }

        public void DeleteItem(int id)
        {
            _itemRepository.DeleteItem(id);
        }

        // validate the name length
        public bool ValidateItemName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.Length <= 10;
        }
    }
}