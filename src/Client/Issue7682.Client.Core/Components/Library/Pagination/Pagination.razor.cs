using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Issue7682.Client.Core.Components.Library.Pagination;
public partial class Pagination : AppComponentBase
{

    [Parameter] public BitDataGridPaginationState State { get; set; }
}
