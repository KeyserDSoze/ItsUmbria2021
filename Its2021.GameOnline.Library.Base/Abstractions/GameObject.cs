using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.GameOnline.Library.Base.Abstractions
{
    public class GameObject
    {
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}
