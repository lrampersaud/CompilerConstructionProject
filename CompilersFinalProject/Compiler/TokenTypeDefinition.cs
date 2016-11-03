﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilersFinalProject.Compiler
{
    public enum TokenTypeDefinition
    {
        TK_A_VAR = 0,
        TK_A_LABEL = 1,
        TK_AN_ARRAY = 2,
        TK_BREAK = 3,
        TK_CASE = 4,
        TK_CHAR = 5,
        TK_CONST = 6,
        TK_CONTINUE = 7,
        TK_DEFAULT = 8,
        TK_DO = 9,
        TK_DOUBLE = 10,
        TK_ELSE = 11,
        TK_ENUM = 12,
        TK_EXTERN = 13,
        TK_FLOAT = 14,
        TK_FOR = 15,
        TK_GOTO = 16,
        TK_IF = 17,
        TK_INT = 18,
        TK_LONG = 19,
        TK_MAIN = 20,
        TK_REGISTER = 21,
        TK_RETURN = 22,
        TK_SHORT = 23,
        TK_SIGNED = 24,
        TK_SIZEOF = 25,
        TK_STATIC = 26,
        TK_STRUCT = 27,
        TK_SWITCH = 28,
        TK_TYPEDEF = 29,
        TK_UNION = 30,
        TK_UNSIGNED = 31,
        TK_VOID = 32,
        TK_VOLATILE = 33,
        TK_WHILE = 34,
        TK_ARGC = 35,
        TK_ID = 36,
        TK_NOTEQ = 37,
        TK_NOT = 38,
        TK_ASMOD = 39,
        TK_MOD = 40,
        TK_LOGAND = 41,
        TK_ASAND = 42,
        TK_AMPER = 43,
        TK_LPAREN = 44,
        TK_RPAREN = 45,
        TK_ASMUL = 46,
        TK_STAR = 47,
        TK_INCR = 48,
        TK_ASPLUS = 49,
        TK_PLUS = 50,
        TK_COMMA = 51,
        TK_DECR = 52,
        TK_ASMINUS = 53,
        TK_MINUS = 54,
        TK_ASDIV = 55,
        TK_SLASH = 56,
        TK_COLOM = 57,
        TK_SEMI = 58,
        TK_ASLSHIFT = 59,
        TK_LSHIFT = 60,
        TK_LTEQ = 61,
        TK_LESS = 62,
        TK_EQUAL = 63,
        TK_ASSIGN = 64,
        TK_ASRSHIFT = 65,
        TK_RSHIFT = 66,
        TK_GTEQ = 67,
        TK_GREATER = 68,
        TK_QMARK = 69,
        TK_LBRACK = 70,
        TK_RBRACK = 71,
        TK_ASXOR = 72,
        TK_CARET = 73,
        TK_LBRACE = 74,
        TK_RBRACE = 75,
        TK_LOGOR = 76,
        TK_ASOR = 77,
        TK_PIPE = 78,
        TK_P_DEFINE = 79,
        TK_P_INCLUDE = 80,
        TK_P_ENDIF = 81,
        TK_P_ELSE = 82,
        TK_P_ELSENOT = 83,
        TK_P_IFDEF = 84,
        TK_P_IFNDEF = 85,
        TK_P_UNDEF = 86,

        TK_INTLIT = 87,
        TK_REALLIT = 88,
        TK_CHARLIT = 89,

        TK_AUTO = 90,
        TK_OUT = 91,
        TK_EMPTY = 92,

        TK_BOOL = 93,
        TK_BOOLLIT = 94
    }
}