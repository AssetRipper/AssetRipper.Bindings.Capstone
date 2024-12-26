namespace AssetRipper.Bindings.Capstone;

public enum cs_ac_type
{
    CS_AC_INVALID = 0,
    CS_AC_READ = 1 << 0,
    CS_AC_WRITE = 1 << 1,
    CS_AC_READ_WRITE = CS_AC_READ | CS_AC_WRITE,
}
