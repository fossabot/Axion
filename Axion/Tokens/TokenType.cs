﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Axion.Tokens {
    /// <summary>
    ///     Represents a &lt;<see cref="Token.Type" />&gt;.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenType {
        Unknown,
        Invalid,

        Operator,
        Identifier,

        CommentLiteral,
        CharLiteral,
        StringLiteral,
        IntegerLiteral,
        RealLiteral,
        FloatLiteral,

        OpLeftParenthesis    = 40,
        OpRightParenthesis   = 41,
        OpLeftBracket        = 42,
        OpRightBracket       = 43,
        OpLeftBrace          = 44,
        OpRightBrace         = 45,
        OpDot                = 46,
        OpIncrement          = 47,
        OpDecrement          = 48,
        OpNot                = 49,
        OpBitwiseNot         = 50,
        OpMultiply           = 51,
        OpTrueDivide         = 52,
        OpRemainder          = 53,
        OpAdd                = 54,
        OpSubtract           = 55,
        OpLeftShift          = 56,
        OpRightShift         = 57,
        OpIn                 = 58,
        OpLessThan           = 59,
        OpLessThanOrEqual    = 60,
        OpGreaterThan        = 61,
        OpGreaterThanOrEqual = 62,
        OpEquals             = 63,
        OpNotEquals          = 64,
        OpBitwiseAnd         = 65,
        OpExclusiveOr        = 66,
        OpBitwiseOr          = 67,
        OpAnd                = 68,
        OpOr                 = 69,
        OpAssign             = 70,
        OpAddEqual           = 71,
        OpSubtractEqual      = 72,
        OpMultiplyEqual      = 73,
        OpTrueDivideEqual    = 74,
        OpRemainderEqual     = 75,
        OpLeftShiftEqual     = 76,
        OpRightShiftEqual    = 77,
        OpBitwiseAndEqual    = 78,
        OpBitwiseOrEqual     = 79,
        OpExclusiveOrEqual   = 80,
        OpRightArrow         = 81,
        OpComma              = 82,
        OpColon              = 83,
        OpSemicolon          = 84,

        FirstKeyword    = KeywordAnd,
        LastKeyword     = KeywordFalse,
        KeywordAnd      = 90,
        KeywordAnyway   = 91,
        KeywordAs       = 92,
        KeywordAssert   = 93,
        KeywordAsync    = 94,
        KeywordAwait    = 95,
        KeywordBreak    = 96,
        KeywordCase     = 97,
        KeywordCatch    = 98,
        KeywordClass    = 99,
        KeywordConst    = 100,
        KeywordContinue = 101,
        KeywordDefault  = 102,
        KeywordDo       = 103,
        KeywordElif     = 104,
        KeywordElse     = 105,
        KeywordEnum     = 106,
        KeywordExtends  = 107,
        KeywordFalse    = 108,
        KeywordFor      = 109,
        KeywordIf       = 110,
        KeywordIn       = 111,
        KeywordInner    = 112,
        KeywordIs       = 113,
        KeywordMatch    = 114,
        KeywordModule   = 115,
        KeywordNew      = 116,
        KeywordNull     = 117,
        KeywordOr       = 118,
        KeywordPrivate  = 119,
        KeywordPublic   = 120,
        KeywordReact    = 121,
        KeywordReadonly = 122,
        KeywordReturn   = 123,
        KeywordSelf     = 124,
        KeywordStatic   = 125,
        KeywordStruct   = 126,
        KeywordThrow    = 127,
        KeywordTrue     = 128,
        KeywordTry      = 129,
        KeywordUse      = 130,
        KeywordVar      = 131,
        KeywordWhile    = 132,
        KeywordYield    = 133,

        Newline,
        Indent,
        Outdent,
        EndOfFile
    }
}