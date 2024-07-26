module Thoth.Json.Codec.Tests.Utils

open Thoth.Json.Codec
open Thoth.Json.Core
#if FABLE_COMPILER
open Fable.Mocha
#else
open Expecto
open Thoth.Json.Newtonsoft
#endif

let roundTrip (codec: Codec<'t>) v =
    let encoded = v |> Encode.codec codec |> Encode.toString 2

    let decoded = encoded |> Decode.fromString (Decode.codec codec)

    Expect.wantOk decoded "Decoding must succeed"
