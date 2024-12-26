using System;

namespace AssetRipper.Bindings.Capstone;

public sealed class CapstoneException : Exception
{
	public CapstoneException(cs_err error)
		: base(Capstone.GetErrorString(error) ?? $"Capstone error: {error}")
	{
	}
}
