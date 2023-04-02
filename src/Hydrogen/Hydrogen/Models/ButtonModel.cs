using System;

namespace Hydrogen.Models;

public sealed record ButtonModel(string Text, Action OnClick);