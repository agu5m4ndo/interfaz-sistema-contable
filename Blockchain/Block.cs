using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace Sistema_contable
{
    [Serializable]
    public class Block
    {
        public Seat seat { get; set; }
        public string Hash { get; set; }
        public string PreviousHash { get; set; }

        public Block(){}

        public Block(Seat seat, Blockchain blockchain)
        {
            this.seat = seat;
            this.Hash = Miner.MineBlock(seat);
            if (blockchain.Blocks.Count == 0)
            {
                this.PreviousHash = Miner.CalculateHash("Cero");
            }
            else
            {
                this.PreviousHash = blockchain.Blocks[blockchain.Blocks.Count - 1].Hash;
            }
        }
    }
}

        