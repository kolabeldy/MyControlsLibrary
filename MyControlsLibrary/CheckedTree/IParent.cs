using System.Collections.Generic;

namespace MyControlsLibrary.CheckedTree;
interface IParent<T>
{
    IEnumerable<T> GetChildren();
}