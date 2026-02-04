name: Sprite

pass:
  vert: "./Sprite.vert"
  frag: "./Sprite.frag"

properties:
  _MainTex: { type: Texture, default: "BuiltIn/Sprites/WhiteQuad.png" }
  _Color: { type: Vector4, default: [256, 256, 256, 256] }
