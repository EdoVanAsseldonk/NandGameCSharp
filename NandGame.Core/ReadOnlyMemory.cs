using System.Collections.Generic;

namespace NandGame.Core
{
    public class ReadOnlyMemory : IReadOnlyMemory
    {
        private readonly Dictionary<int, Byte2> _content = new Dictionary<int, Byte2>();

        public ReadOnlyMemory()
        {
            _content.Add(0, new Byte2("1110101010100000"));
            _content.Add(1, new Byte2("1110111111001000"));
            _content.Add(2, new Byte2("1110110111100000"));
            _content.Add(3, new Byte2("1110111111001000"));
            _content.Add(4, new Byte2("1110110000010000"));
            _content.Add(5, new Byte2("1110001110100000"));
            _content.Add(6, new Byte2("1111110000010000"));
            _content.Add(7, new Byte2("1110110111100000"));
            _content.Add(8, new Byte2("1111000010010000"));
            _content.Add(9, new Byte2("1110110111100000"));
            _content.Add(10, new Byte2("1110001100001000"));
            _content.Add(11, new Byte2("1110110000010000"));
            _content.Add(12, new Byte2("0000000000000101"));
            _content.Add(13, new Byte2("1110001100000001"));
            _content.Add(14, new Byte2("0000000000001110"));
            _content.Add(15, new Byte2("1110101010000111"));
            _content.Add(16, new Byte2("0000000000000000"));
        }

        public ReadOnlyMemory(Dictionary<int, Byte2> content)
        {
            _content = content;
        }

        public Byte2 Read(Byte2 address)
        {
            return _content[address.ToInt16()];
        }
    }

    public interface IReadOnlyMemory
    {
        Byte2 Read(Byte2 address);
    }
}