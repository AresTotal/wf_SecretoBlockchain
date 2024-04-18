using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace wf_SecretoClient
{
    /// <summary>
    /// Блок данных.
    /// </summary>
    public class Block
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Данные.
        /// </summary>
        public string data { get; private set; }
        /// <summary>
        /// Данные о пользователе.
        /// </summary>
        public string user { get; private set; }
        /// <summary>
        /// Дата и время создания.
        /// </summary>
        public DateTime created { get; private set; }
        /// <summary>
        /// Используемая хэш функция.
        /// </summary>
        public string hashAlgorithm { get; private set; }
        /// <summary>
        /// Хэш текущего блока.
        /// </summary>
        public string hash { get; private set; }
        /// <summary>
        /// Хэш предыдущего блока.
        /// </summary>
        public string previousHash { get; private set; }
        /// <summary>
        /// Конструктор генезис блока.
        /// </summary>
        public Block()
        {
            Id = 0;
            data = "Первый блок генезиса на кириллице";
            user = "Admin";
            created = DateTime.Parse("03.04.2024 00:00:00.000").ToUniversalTime();
            hashAlgorithm = "SHA-256";
            previousHash = "34733473";

            var blockData = GetData();
            hash = GetHash(blockData);
        }
        /// <summary>
        /// Конструктор блока данных.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="block">Предыдущий блок данных.</param>
        /// <param name="data">Данные.</param>
        /// <param name="user">Пользователь.</param>
        /// <param name="сreated">Время создания.</param>
        /// <param name="hashAlgorithm"></param>
        /// <param name="previousHash"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Block(Block block, string data, string hashAlgorithm)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                throw new ArgumentNullException("Пустое значение " + nameof(data));
            }

            if (block == null)
            {
                throw new ArgumentNullException("Не найдено значение");
            }

            if (string.IsNullOrWhiteSpace(hashAlgorithm))
            {
                throw new ArgumentNullException("Отстутствует аргумент " + nameof(hashAlgorithm));
            }

            Id = block.Id + 1;
            this.data = data;
            this.user = Environment.UserName;
            this.created = DateTime.UtcNow;
            this.hashAlgorithm = hashAlgorithm;
            this.previousHash = block.hash;

            var blockData = GetData();
            hash = GetHash(blockData);
        }
        /// <summary>
        /// Создание строки для хэширования.
        /// </summary>
        /// <returns></returns>
        private string GetData()
        {
            string result = "";

            result += Id.ToString();
            result += data;
            result += created.ToString("dd.MM.yyyy HH:mm:ss.fff");
            result += previousHash;
            result += user;
            result += hashAlgorithm;

            return result;
        }
        /// <summary>
        /// Хэширование.
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <returns></returns>
        private string GetHash(string data)
        {
            var message = Encoding.UTF8.GetBytes(data);
            var hashString = new SHA256Managed();

            string hex = "";

            var hashValue = hashString.ComputeHash(message);

            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

        public override string ToString()
        {
            return $"{Id} | {data} | {user} | {created} | {hashAlgorithm} | {previousHash} | {hash}";
        }

        public string[] ToArray()
        {
            return new string[] { Id.ToString(), data, user, created.ToString(), hashAlgorithm, previousHash, hash };
        }
    }
}
