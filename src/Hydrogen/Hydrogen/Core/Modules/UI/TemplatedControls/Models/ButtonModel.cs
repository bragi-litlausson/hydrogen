using System;

namespace Hydrogen.Core.Modules.UI.TemplatedControls.Models;

public sealed record ButtonModel(string Text, Action OnClick);