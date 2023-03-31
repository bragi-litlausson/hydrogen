using System;

namespace Hydrogen.Models;

public sealed record MenuOptionModel(string Text, Action OnClick);