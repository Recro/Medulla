using Microsoft.AspNetCore.Components;
using DatabaseDesigner.Core.Models;
using DatabaseDesigner.Wasm.Components.Database.TableNode.TableColumnNode;
using Blazor.Diagrams.Core;
using System;

namespace DatabaseDesigner.Wasm.Components.RegisteredComponents.Header
{
    public partial class Header
    {
        [Parameter]
        public DatabaseDesigner.Core.Models.RegisteredComponents.Header Node { get; set; }

        [Parameter]
        public bool InTray { get; set; } = false;

        [Parameter]
        public Diagram Diagram { get; set; }

        
        [Parameter]
        public Action<Diagram> AddToScene { get; set; }

        private Entity Entity { get; set; }

        public void QuickLoadingOnEntity() => Entity.QuickLoading();

        [Parameter]
        public RenderFragment Preview { get; set; }

    

    }
}