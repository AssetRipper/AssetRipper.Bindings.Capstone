using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public static unsafe partial class Capstone
{
    [NativeTypeName("#define AARCH64_SLICE_IMM_INVALID UINT16_MAX")]
    public const ushort AARCH64_SLICE_IMM_INVALID = unchecked(0xffff);

    [NativeTypeName("#define AARCH64_SLICE_IMM_RANGE_INVALID UINT8_MAX")]
    public const byte AARCH64_SLICE_IMM_RANGE_INVALID = unchecked(0xff);

    [NativeTypeName("#define NUM_AARCH64_OPS 16")]
    public const int NUM_AARCH64_OPS = 16;

    [NativeTypeName("#define NUM_ALPHA_OPS 3")]
    public const int NUM_ALPHA_OPS = 3;

    [NativeTypeName("#define NUM_ARM_OPS 36")]
    public const int NUM_ARM_OPS = 36;

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint cs_version(int* major, int* minor);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_arm();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_aarch64();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_mips();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_x86();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_powerpc();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_sparc();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_systemz();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_xcore();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_m68k();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_tms320c64x();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_m680x();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_evm();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_mos65xx();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_wasm();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_bpf();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_riscv();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_sh();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_tricore();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_alpha();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_arch_register_loongarch();

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern bool cs_support(int query);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern cs_err cs_open(cs_arch arch, cs_mode mode, [NativeTypeName("csh *")] nuint* handle);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern cs_err cs_close([NativeTypeName("csh *")] nuint* handle);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern cs_err cs_option([NativeTypeName("csh")] nuint handle, cs_opt_type type, [NativeTypeName("size_t")] nuint value);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern cs_err cs_errno([NativeTypeName("csh")] nuint handle);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* cs_strerror(cs_err code);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint cs_disasm([NativeTypeName("csh")] nuint handle, [NativeTypeName("const uint8_t *")] byte* code, [NativeTypeName("size_t")] nuint code_size, [NativeTypeName("uint64_t")] ulong address, [NativeTypeName("size_t")] nuint count, cs_insn** insn);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cs_free(cs_insn* insn, [NativeTypeName("size_t")] nuint count);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern cs_insn* cs_malloc([NativeTypeName("csh")] nuint handle);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern bool cs_disasm_iter([NativeTypeName("csh")] nuint handle, [NativeTypeName("const uint8_t **")] byte** code, [NativeTypeName("size_t *")] nuint* size, [NativeTypeName("uint64_t *")] ulong* address, cs_insn* insn);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* cs_reg_name([NativeTypeName("csh")] nuint handle, [NativeTypeName("unsigned int")] uint reg_id);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* cs_insn_name([NativeTypeName("csh")] nuint handle, [NativeTypeName("unsigned int")] uint insn_id);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* cs_group_name([NativeTypeName("csh")] nuint handle, [NativeTypeName("unsigned int")] uint group_id);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern bool cs_insn_group([NativeTypeName("csh")] nuint handle, [NativeTypeName("const cs_insn *")] cs_insn* insn, [NativeTypeName("unsigned int")] uint group_id);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern bool cs_reg_read([NativeTypeName("csh")] nuint handle, [NativeTypeName("const cs_insn *")] cs_insn* insn, [NativeTypeName("unsigned int")] uint reg_id);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern bool cs_reg_write([NativeTypeName("csh")] nuint handle, [NativeTypeName("const cs_insn *")] cs_insn* insn, [NativeTypeName("unsigned int")] uint reg_id);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int cs_op_count([NativeTypeName("csh")] nuint handle, [NativeTypeName("const cs_insn *")] cs_insn* insn, [NativeTypeName("unsigned int")] uint op_type);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int cs_op_index([NativeTypeName("csh")] nuint handle, [NativeTypeName("const cs_insn *")] cs_insn* insn, [NativeTypeName("unsigned int")] uint op_type, [NativeTypeName("unsigned int")] uint position);

    [DllImport("capstone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern cs_err cs_regs_access([NativeTypeName("csh")] nuint handle, [NativeTypeName("const cs_insn *")] cs_insn* insn, [NativeTypeName("cs_regs")] ushort* regs_read, [NativeTypeName("uint8_t *")] byte* regs_read_count, [NativeTypeName("cs_regs")] ushort* regs_write, [NativeTypeName("uint8_t *")] byte* regs_write_count);

    [NativeTypeName("#define CS_API_MAJOR 6")]
    public const int CS_API_MAJOR = 6;

    [NativeTypeName("#define CS_API_MINOR 0")]
    public const int CS_API_MINOR = 0;

    [NativeTypeName("#define CS_NEXT_VERSION 7")]
    public const int CS_NEXT_VERSION = 7;

    [NativeTypeName("#define CS_VERSION_MAJOR CS_API_MAJOR")]
    public const int CS_VERSION_MAJOR = 6;

    [NativeTypeName("#define CS_VERSION_MINOR CS_API_MINOR")]
    public const int CS_VERSION_MINOR = 0;

    [NativeTypeName("#define CS_VERSION_EXTRA 0")]
    public const int CS_VERSION_EXTRA = 0;

    [NativeTypeName("#define CS_MNEMONIC_SIZE 32")]
    public const int CS_MNEMONIC_SIZE = 32;

    [NativeTypeName("#define CS_SUPPORT_DIET (CS_ARCH_ALL + 1)")]
    public const int CS_SUPPORT_DIET = ((int)(cs_arch.CS_ARCH_ALL) + 1);

    [NativeTypeName("#define CS_SUPPORT_X86_REDUCE (CS_ARCH_ALL + 2)")]
    public const int CS_SUPPORT_X86_REDUCE = ((int)(cs_arch.CS_ARCH_ALL) + 2);

    [NativeTypeName("#define MAX_IMPL_W_REGS 47")]
    public const int MAX_IMPL_W_REGS = 47;

    [NativeTypeName("#define MAX_IMPL_R_REGS 20")]
    public const int MAX_IMPL_R_REGS = 20;

    [NativeTypeName("#define MAX_NUM_GROUPS 16")]
    public const int MAX_NUM_GROUPS = 16;

    [NativeTypeName("#define NUM_HPPA_OPS 5")]
    public const int NUM_HPPA_OPS = 5;

    [NativeTypeName("#define HPPA_STR_MODIFIER_LEN 8")]
    public const int HPPA_STR_MODIFIER_LEN = 8;

    [NativeTypeName("#define HPPA_MAX_MODIFIERS_LEN 5")]
    public const int HPPA_MAX_MODIFIERS_LEN = 5;

    [NativeTypeName("#define NUM_LOONGARCH_OPS 8")]
    public const int NUM_LOONGARCH_OPS = 8;

    [NativeTypeName("#define M680X_OPERAND_COUNT 9")]
    public const int M680X_OPERAND_COUNT = 9;

    [NativeTypeName("#define M680X_OFFSET_NONE 0")]
    public const int M680X_OFFSET_NONE = 0;

    [NativeTypeName("#define M680X_OFFSET_BITS_5 5")]
    public const int M680X_OFFSET_BITS_5 = 5;

    [NativeTypeName("#define M680X_OFFSET_BITS_8 8")]
    public const int M680X_OFFSET_BITS_8 = 8;

    [NativeTypeName("#define M680X_OFFSET_BITS_9 9")]
    public const int M680X_OFFSET_BITS_9 = 9;

    [NativeTypeName("#define M680X_OFFSET_BITS_16 16")]
    public const int M680X_OFFSET_BITS_16 = 16;

    [NativeTypeName("#define M680X_IDX_INDIRECT 1")]
    public const int M680X_IDX_INDIRECT = 1;

    [NativeTypeName("#define M680X_IDX_NO_COMMA 2")]
    public const int M680X_IDX_NO_COMMA = 2;

    [NativeTypeName("#define M680X_IDX_POST_INC_DEC 4")]
    public const int M680X_IDX_POST_INC_DEC = 4;

    [NativeTypeName("#define M680X_FIRST_OP_IN_MNEM 1")]
    public const int M680X_FIRST_OP_IN_MNEM = 1;

    [NativeTypeName("#define M680X_SECOND_OP_IN_MNEM 2")]
    public const int M680X_SECOND_OP_IN_MNEM = 2;

    [NativeTypeName("#define M68K_OPERAND_COUNT 4")]
    public const int M68K_OPERAND_COUNT = 4;

    [NativeTypeName("#define NUM_MIPS_OPS 10")]
    public const int NUM_MIPS_OPS = 10;

    [NativeTypeName("#define PPC_INSN_FORM_B_BO_MASK 0x03e00000")]
    public const int PPC_INSN_FORM_B_BO_MASK = 0x03e00000;

    [NativeTypeName("#define PPC_INSN_FORM_XL_BO_MASK 0x03e00000")]
    public const int PPC_INSN_FORM_XL_BO_MASK = 0x03e00000;

    [NativeTypeName("#define PPC_INSN_FORM_B_BI_MASK 0x001f0000")]
    public const int PPC_INSN_FORM_B_BI_MASK = 0x001f0000;

    [NativeTypeName("#define PPC_INSN_FORM_XL_BI_MASK 0x001f0000")]
    public const int PPC_INSN_FORM_XL_BI_MASK = 0x001f0000;

    [NativeTypeName("#define PPC_INSN_FORM_XL_BH_MASK 0x00001800")]
    public const int PPC_INSN_FORM_XL_BH_MASK = 0x00001800;

    [NativeTypeName("#define PPC_INSN_FORM_XL_XO_MASK 0x000007fe")]
    public const int PPC_INSN_FORM_XL_XO_MASK = 0x000007fe;

    [NativeTypeName("#define NUM_PPC_OPS 8")]
    public const int NUM_PPC_OPS = 8;

    [NativeTypeName("#define NUM_RISCV_OPS 8")]
    public const int NUM_RISCV_OPS = 8;

    [NativeTypeName("#define NUM_SYSTEMZ_OPS 6")]
    public const int NUM_SYSTEMZ_OPS = 6;

    [NativeTypeName("#define NUM_TRICORE_OPS 8")]
    public const int NUM_TRICORE_OPS = 8;

    [NativeTypeName("#define X86_EFLAGS_MODIFY_AF (1ULL << 0)")]
    public const ulong X86_EFLAGS_MODIFY_AF = (1UL << 0);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_CF (1ULL << 1)")]
    public const ulong X86_EFLAGS_MODIFY_CF = (1UL << 1);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_SF (1ULL << 2)")]
    public const ulong X86_EFLAGS_MODIFY_SF = (1UL << 2);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_ZF (1ULL << 3)")]
    public const ulong X86_EFLAGS_MODIFY_ZF = (1UL << 3);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_PF (1ULL << 4)")]
    public const ulong X86_EFLAGS_MODIFY_PF = (1UL << 4);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_OF (1ULL << 5)")]
    public const ulong X86_EFLAGS_MODIFY_OF = (1UL << 5);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_TF (1ULL << 6)")]
    public const ulong X86_EFLAGS_MODIFY_TF = (1UL << 6);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_IF (1ULL << 7)")]
    public const ulong X86_EFLAGS_MODIFY_IF = (1UL << 7);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_DF (1ULL << 8)")]
    public const ulong X86_EFLAGS_MODIFY_DF = (1UL << 8);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_NT (1ULL << 9)")]
    public const ulong X86_EFLAGS_MODIFY_NT = (1UL << 9);

    [NativeTypeName("#define X86_EFLAGS_MODIFY_RF (1ULL << 10)")]
    public const ulong X86_EFLAGS_MODIFY_RF = (1UL << 10);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_OF (1ULL << 11)")]
    public const ulong X86_EFLAGS_PRIOR_OF = (1UL << 11);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_SF (1ULL << 12)")]
    public const ulong X86_EFLAGS_PRIOR_SF = (1UL << 12);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_ZF (1ULL << 13)")]
    public const ulong X86_EFLAGS_PRIOR_ZF = (1UL << 13);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_AF (1ULL << 14)")]
    public const ulong X86_EFLAGS_PRIOR_AF = (1UL << 14);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_PF (1ULL << 15)")]
    public const ulong X86_EFLAGS_PRIOR_PF = (1UL << 15);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_CF (1ULL << 16)")]
    public const ulong X86_EFLAGS_PRIOR_CF = (1UL << 16);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_TF (1ULL << 17)")]
    public const ulong X86_EFLAGS_PRIOR_TF = (1UL << 17);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_IF (1ULL << 18)")]
    public const ulong X86_EFLAGS_PRIOR_IF = (1UL << 18);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_DF (1ULL << 19)")]
    public const ulong X86_EFLAGS_PRIOR_DF = (1UL << 19);

    [NativeTypeName("#define X86_EFLAGS_PRIOR_NT (1ULL << 20)")]
    public const ulong X86_EFLAGS_PRIOR_NT = (1UL << 20);

    [NativeTypeName("#define X86_EFLAGS_RESET_OF (1ULL << 21)")]
    public const ulong X86_EFLAGS_RESET_OF = (1UL << 21);

    [NativeTypeName("#define X86_EFLAGS_RESET_CF (1ULL << 22)")]
    public const ulong X86_EFLAGS_RESET_CF = (1UL << 22);

    [NativeTypeName("#define X86_EFLAGS_RESET_DF (1ULL << 23)")]
    public const ulong X86_EFLAGS_RESET_DF = (1UL << 23);

    [NativeTypeName("#define X86_EFLAGS_RESET_IF (1ULL << 24)")]
    public const ulong X86_EFLAGS_RESET_IF = (1UL << 24);

    [NativeTypeName("#define X86_EFLAGS_RESET_SF (1ULL << 25)")]
    public const ulong X86_EFLAGS_RESET_SF = (1UL << 25);

    [NativeTypeName("#define X86_EFLAGS_RESET_AF (1ULL << 26)")]
    public const ulong X86_EFLAGS_RESET_AF = (1UL << 26);

    [NativeTypeName("#define X86_EFLAGS_RESET_TF (1ULL << 27)")]
    public const ulong X86_EFLAGS_RESET_TF = (1UL << 27);

    [NativeTypeName("#define X86_EFLAGS_RESET_NT (1ULL << 28)")]
    public const ulong X86_EFLAGS_RESET_NT = (1UL << 28);

    [NativeTypeName("#define X86_EFLAGS_RESET_PF (1ULL << 29)")]
    public const ulong X86_EFLAGS_RESET_PF = (1UL << 29);

    [NativeTypeName("#define X86_EFLAGS_SET_CF (1ULL << 30)")]
    public const ulong X86_EFLAGS_SET_CF = (1UL << 30);

    [NativeTypeName("#define X86_EFLAGS_SET_DF (1ULL << 31)")]
    public const ulong X86_EFLAGS_SET_DF = (1UL << 31);

    [NativeTypeName("#define X86_EFLAGS_SET_IF (1ULL << 32)")]
    public const ulong X86_EFLAGS_SET_IF = (1UL << 32);

    [NativeTypeName("#define X86_EFLAGS_TEST_OF (1ULL << 33)")]
    public const ulong X86_EFLAGS_TEST_OF = (1UL << 33);

    [NativeTypeName("#define X86_EFLAGS_TEST_SF (1ULL << 34)")]
    public const ulong X86_EFLAGS_TEST_SF = (1UL << 34);

    [NativeTypeName("#define X86_EFLAGS_TEST_ZF (1ULL << 35)")]
    public const ulong X86_EFLAGS_TEST_ZF = (1UL << 35);

    [NativeTypeName("#define X86_EFLAGS_TEST_PF (1ULL << 36)")]
    public const ulong X86_EFLAGS_TEST_PF = (1UL << 36);

    [NativeTypeName("#define X86_EFLAGS_TEST_CF (1ULL << 37)")]
    public const ulong X86_EFLAGS_TEST_CF = (1UL << 37);

    [NativeTypeName("#define X86_EFLAGS_TEST_NT (1ULL << 38)")]
    public const ulong X86_EFLAGS_TEST_NT = (1UL << 38);

    [NativeTypeName("#define X86_EFLAGS_TEST_DF (1ULL << 39)")]
    public const ulong X86_EFLAGS_TEST_DF = (1UL << 39);

    [NativeTypeName("#define X86_EFLAGS_UNDEFINED_OF (1ULL << 40)")]
    public const ulong X86_EFLAGS_UNDEFINED_OF = (1UL << 40);

    [NativeTypeName("#define X86_EFLAGS_UNDEFINED_SF (1ULL << 41)")]
    public const ulong X86_EFLAGS_UNDEFINED_SF = (1UL << 41);

    [NativeTypeName("#define X86_EFLAGS_UNDEFINED_ZF (1ULL << 42)")]
    public const ulong X86_EFLAGS_UNDEFINED_ZF = (1UL << 42);

    [NativeTypeName("#define X86_EFLAGS_UNDEFINED_PF (1ULL << 43)")]
    public const ulong X86_EFLAGS_UNDEFINED_PF = (1UL << 43);

    [NativeTypeName("#define X86_EFLAGS_UNDEFINED_AF (1ULL << 44)")]
    public const ulong X86_EFLAGS_UNDEFINED_AF = (1UL << 44);

    [NativeTypeName("#define X86_EFLAGS_UNDEFINED_CF (1ULL << 45)")]
    public const ulong X86_EFLAGS_UNDEFINED_CF = (1UL << 45);

    [NativeTypeName("#define X86_EFLAGS_RESET_RF (1ULL << 46)")]
    public const ulong X86_EFLAGS_RESET_RF = (1UL << 46);

    [NativeTypeName("#define X86_EFLAGS_TEST_RF (1ULL << 47)")]
    public const ulong X86_EFLAGS_TEST_RF = (1UL << 47);

    [NativeTypeName("#define X86_EFLAGS_TEST_IF (1ULL << 48)")]
    public const ulong X86_EFLAGS_TEST_IF = (1UL << 48);

    [NativeTypeName("#define X86_EFLAGS_TEST_TF (1ULL << 49)")]
    public const ulong X86_EFLAGS_TEST_TF = (1UL << 49);

    [NativeTypeName("#define X86_EFLAGS_TEST_AF (1ULL << 50)")]
    public const ulong X86_EFLAGS_TEST_AF = (1UL << 50);

    [NativeTypeName("#define X86_EFLAGS_RESET_ZF (1ULL << 51)")]
    public const ulong X86_EFLAGS_RESET_ZF = (1UL << 51);

    [NativeTypeName("#define X86_EFLAGS_SET_OF (1ULL << 52)")]
    public const ulong X86_EFLAGS_SET_OF = (1UL << 52);

    [NativeTypeName("#define X86_EFLAGS_SET_SF (1ULL << 53)")]
    public const ulong X86_EFLAGS_SET_SF = (1UL << 53);

    [NativeTypeName("#define X86_EFLAGS_SET_ZF (1ULL << 54)")]
    public const ulong X86_EFLAGS_SET_ZF = (1UL << 54);

    [NativeTypeName("#define X86_EFLAGS_SET_AF (1ULL << 55)")]
    public const ulong X86_EFLAGS_SET_AF = (1UL << 55);

    [NativeTypeName("#define X86_EFLAGS_SET_PF (1ULL << 56)")]
    public const ulong X86_EFLAGS_SET_PF = (1UL << 56);

    [NativeTypeName("#define X86_EFLAGS_RESET_0F (1ULL << 57)")]
    public const ulong X86_EFLAGS_RESET_0F = (1UL << 57);

    [NativeTypeName("#define X86_EFLAGS_RESET_AC (1ULL << 58)")]
    public const ulong X86_EFLAGS_RESET_AC = (1UL << 58);

    [NativeTypeName("#define X86_FPU_FLAGS_MODIFY_C0 (1ULL << 0)")]
    public const ulong X86_FPU_FLAGS_MODIFY_C0 = (1UL << 0);

    [NativeTypeName("#define X86_FPU_FLAGS_MODIFY_C1 (1ULL << 1)")]
    public const ulong X86_FPU_FLAGS_MODIFY_C1 = (1UL << 1);

    [NativeTypeName("#define X86_FPU_FLAGS_MODIFY_C2 (1ULL << 2)")]
    public const ulong X86_FPU_FLAGS_MODIFY_C2 = (1UL << 2);

    [NativeTypeName("#define X86_FPU_FLAGS_MODIFY_C3 (1ULL << 3)")]
    public const ulong X86_FPU_FLAGS_MODIFY_C3 = (1UL << 3);

    [NativeTypeName("#define X86_FPU_FLAGS_RESET_C0 (1ULL << 4)")]
    public const ulong X86_FPU_FLAGS_RESET_C0 = (1UL << 4);

    [NativeTypeName("#define X86_FPU_FLAGS_RESET_C1 (1ULL << 5)")]
    public const ulong X86_FPU_FLAGS_RESET_C1 = (1UL << 5);

    [NativeTypeName("#define X86_FPU_FLAGS_RESET_C2 (1ULL << 6)")]
    public const ulong X86_FPU_FLAGS_RESET_C2 = (1UL << 6);

    [NativeTypeName("#define X86_FPU_FLAGS_RESET_C3 (1ULL << 7)")]
    public const ulong X86_FPU_FLAGS_RESET_C3 = (1UL << 7);

    [NativeTypeName("#define X86_FPU_FLAGS_SET_C0 (1ULL << 8)")]
    public const ulong X86_FPU_FLAGS_SET_C0 = (1UL << 8);

    [NativeTypeName("#define X86_FPU_FLAGS_SET_C1 (1ULL << 9)")]
    public const ulong X86_FPU_FLAGS_SET_C1 = (1UL << 9);

    [NativeTypeName("#define X86_FPU_FLAGS_SET_C2 (1ULL << 10)")]
    public const ulong X86_FPU_FLAGS_SET_C2 = (1UL << 10);

    [NativeTypeName("#define X86_FPU_FLAGS_SET_C3 (1ULL << 11)")]
    public const ulong X86_FPU_FLAGS_SET_C3 = (1UL << 11);

    [NativeTypeName("#define X86_FPU_FLAGS_UNDEFINED_C0 (1ULL << 12)")]
    public const ulong X86_FPU_FLAGS_UNDEFINED_C0 = (1UL << 12);

    [NativeTypeName("#define X86_FPU_FLAGS_UNDEFINED_C1 (1ULL << 13)")]
    public const ulong X86_FPU_FLAGS_UNDEFINED_C1 = (1UL << 13);

    [NativeTypeName("#define X86_FPU_FLAGS_UNDEFINED_C2 (1ULL << 14)")]
    public const ulong X86_FPU_FLAGS_UNDEFINED_C2 = (1UL << 14);

    [NativeTypeName("#define X86_FPU_FLAGS_UNDEFINED_C3 (1ULL << 15)")]
    public const ulong X86_FPU_FLAGS_UNDEFINED_C3 = (1UL << 15);

    [NativeTypeName("#define X86_FPU_FLAGS_TEST_C0 (1ULL << 16)")]
    public const ulong X86_FPU_FLAGS_TEST_C0 = (1UL << 16);

    [NativeTypeName("#define X86_FPU_FLAGS_TEST_C1 (1ULL << 17)")]
    public const ulong X86_FPU_FLAGS_TEST_C1 = (1UL << 17);

    [NativeTypeName("#define X86_FPU_FLAGS_TEST_C2 (1ULL << 18)")]
    public const ulong X86_FPU_FLAGS_TEST_C2 = (1UL << 18);

    [NativeTypeName("#define X86_FPU_FLAGS_TEST_C3 (1ULL << 19)")]
    public const ulong X86_FPU_FLAGS_TEST_C3 = (1UL << 19);

    [NativeTypeName("#define MAX_XTENSA_OPS 8")]
    public const int MAX_XTENSA_OPS = 8;
}
