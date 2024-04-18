using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SecretoClient
{
    /// <summary>
    /// Цепочкка блоков.
    /// </summary>
    public class Chain
    {
        /// <summary>
        /// Инициализация списка.
        /// </summary>
        public List<Block> Blocks { get; private set; }

        /// <summary>
        /// Хранение последнего блока данных.
        /// </summary>
        public Block Last { get; private set; }

        /// <summary>
        /// Создание новой цепочки.
        /// </summary>
        public Chain()
        {
            Blocks = LoadChainFromDB();

            if (Blocks.Count == 0)
            {
                var genesisBlock = new Block();

                Blocks.Add(genesisBlock);
                Last = genesisBlock;
            }
            else
            {
                Last = Blocks.Last();
            }
        }

        /// <summary>
        /// Добавление нового блока.
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <param name="user">Пользователь.</param>
        /// <param name="hashAlgorithm">Алгоритм хэширования.</param>
        public void Add(string data, string hashAlgorithm = "SHA-256")
        {
            try
            {
                var block = new Block(Last, data, hashAlgorithm);
                Blocks.Add(block);
                Last = block;
                Save(Last);
            }
            catch (Exception ex)
            {
                data = "Пустое значение";
                var block = new Block(Last, data, hashAlgorithm);
                Blocks.Add(block);
                Last = block;
                Save(Last);
            }
        }

        public bool Check()
        {
            var genesisBlock = new Block();
            var previousHash = genesisBlock.hash;

            if (Blocks.Count == 0)
            {
                foreach (var block in Blocks.Skip(1))
                {
                    var hash = block.previousHash;

                    if (previousHash != hash)
                    {
                        return false;
                    }

                    previousHash = block.hash;
                }
                return true;
            }
            else
            {
                previousHash = Blocks[0].hash;

                foreach (var block in Blocks.Skip(1))
                {
                    var hash = block.previousHash;

                    if (previousHash != hash)
                    {
                        return false;
                    }

                    previousHash = block.hash;
                }
                return true;
            }

        }
        /// <summary>
        /// Запись блока данных в цепочку.
        /// </summary>
        /// <param name="block">Блок данных.</param>
        public void Save(Block block)
        {
            using (BlockchainContext db = new BlockchainContext())
            {
                db.Blocks.Add(block);
                db.SaveChanges();
            }
        }

        public void Clear()
        {
            using (BlockchainContext db = new BlockchainContext())
            {
                try
                {
                    foreach (Block block in Blocks)
                    {
                        db.Blocks.Remove(block);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Прежде чем удалять данные заполните их чем нибудь.");
                }
            }
        }

        /// <summary>
        /// Получение данных из базы данных цепочки данных.
        /// </summary>
        /// <returns>Цепочка данных.</returns>

        public List<Block> LoadChainFromDB()
        {
            List<Block> result;

            using (BlockchainContext db = new BlockchainContext())
            {
                var count = db.Blocks.Count();

                result = new List<Block>(count * 2);

                result.AddRange(db.Blocks);
            }

            return result;
        }
    }
}
