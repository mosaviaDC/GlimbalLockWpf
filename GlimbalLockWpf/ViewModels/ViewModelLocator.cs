using GlimbalLockWpf.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlimbalLockWpf
{
    public class ViewModelLocator
    {
        public InputControlViewModel InputControlViewModel =>App.Host.Services.GetRequiredService<InputControlViewModel>();
    }
}
