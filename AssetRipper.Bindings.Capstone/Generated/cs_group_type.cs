namespace AssetRipper.Bindings.Capstone;

public enum cs_group_type
{
    CS_GRP_INVALID = 0,
    CS_GRP_JUMP,
    CS_GRP_CALL,
    CS_GRP_RET,
    CS_GRP_INT,
    CS_GRP_IRET,
    CS_GRP_PRIVILEGE,
    CS_GRP_BRANCH_RELATIVE,
}
