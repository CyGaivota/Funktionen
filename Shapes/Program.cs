using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Shapes
{
    internal class Rectangle
    {

        static void Main(string[] args)
        {
        // 1. Ein Feld mit einem für Felder typischen Zugriffsmodifizierer. 
        private string? name { get; set; }

        // 2. Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann.
        // ??? Instanziieren Sie anschliessend ein Objekt der betreffenden Klasse und überprüfen Sie den Wert mit dem Debugger.

        private readonly int length;
        private readonly int width;

        public int Area => this.width * this.length;
        }
     }


    // 3. Ein Feld, für welches ein Standardwert zugewiesen wird.
    // Instanziieren Sie anschliessend ein Objekt der betreffenden Klasse,
    // weisen Sie dem Feld einen anderen Wert zu und beobachten Sie die Veränderung im Debugger. 


    // 4. Eine selber implementierte, read-only Eigenschaft.

}




