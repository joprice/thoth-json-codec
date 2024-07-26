module Thoth.Json.Codec.Tests.Auto

open Thoth.Json.Core
open Thoth.Json.Codec

#if FABLE_COMPILER
open Fable.Mocha
#else
open Expecto
#endif

open Thoth.Json.Codec.Tests.Utils

type Baz = { Baz: bool; Bic: int option }

type Foo =
    { Bar: string; Baz: Baz; Qux: int list }

// module Foo =
//
//   let codec = Codec.Auto.generateCodec(CamelCase)

// let tests =
//     testList
//         "Auto"
//         [ test "Auto.generateCodec works for simple case 1" {
//               let expected =
//                   { Bar = "abc"
//                     Baz = { Baz = true; Bic = Some 123 }
//                     Qux = [ 2; 4; 8 ] }
//
//               let actual = roundTrip Foo.codec expected
//
//               Expect.equal actual expected "The decoded value must match the original"
//           } ]
