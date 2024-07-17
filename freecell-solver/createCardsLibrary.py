
contents = "static class Cards {\n"
for suit in ["diamond", "heart", "club", "spade"]:
    for value in range(13):
        contents += f"\tpublic static Card {suit[0]}{value} = new Card(Suit.{suit}, {value});\n"
contents += "}"

with open("cards.cs", "w+") as file:
    file.write(contents)