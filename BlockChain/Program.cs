// See https://aka.ms/new-console-template for more information
using BlockChain;



var ran = new Random();
IBlock genesis = new Block(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00 });
byte[] difficulty = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00 };
BloKChain chain = new BloKChain(difficulty, genesis);
for(int i = 0; i < 200;i++)
{
    var data =  Enumerable.Range(0,255).Select(p=>(byte)ran.Next()).ToArray();
    chain.Add(new Block(data.ToArray()));
    Console.WriteLine(chain.LastOrDefault()?.ToString());
    if(chain.IsValid())
        Console.WriteLine("blockchain is valid");
}

Console.ReadLine();