using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        IList<T> GetAll();
        T GetById(int id);
    }

    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> _list = new List<T>();

        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public void Delete(T entity)
        {
            _list.Remove(entity);
        }

        public IList<T> GetAll()
        {
            return _list;
        }

        public T GetById(int id)
        {
            return _list[id];
        }
    }

    public  class GenericInterfaceDemo
    {
        //static void Main()
        //{
        //    IRepository<User> userRepository = new Repository<User>();
        //    userRepository.Add(new User { Email = "testuser@testmail.com", Password = "DDF$$$$FFF" });
        //    Console.WriteLine(userRepository.GetById(0).Email);

        //    IRepository<Product> productRepository = new Repository<Product>();
        //    productRepository.Add(new Product());

        //    IRepository<Order> orderRepository = new Repository<Order>();
        //    orderRepository.Add(new Order());
        //}
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Order
    {
        public string CustomerName { get; set; }
        public string TotalPrice { get; set; }
    }
}
