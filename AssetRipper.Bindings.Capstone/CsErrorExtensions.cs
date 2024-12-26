using System.Diagnostics;

namespace AssetRipper.Bindings.Capstone;

internal static class CsErrorExtensions
{
	[StackTraceHidden]
	public static void ThrowOnFailure(this cs_err error)
	{
		if (error != cs_err.CS_ERR_OK)
		{
			throw new CapstoneException(error);
		}
	}
}
