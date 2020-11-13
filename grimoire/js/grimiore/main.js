function main() {
  // Put your code here
  console.log("Do you believe in magic?");
  console.log("------------------------");

  let allSpells = GetAllSpells();
  console.log(allSpells)
  let goodBook = MakeGoodSpellBook(allSpells);
  let evilBook = MakeEvilSpellBook(allSpells);

  DisplaySpellBook(goodBook);
  console.log("");
  DisplaySpellBook(evilBook);
}

const DisplaySpellBook = (book) => {
  console.log(book.title);
  book.spells.map(spell => console.log(spell.name))
}


const MakeEvilSpellBook = (allSpells) => {
  console.log(allSpells)
  let evilBook = {
    title: "Evil Book",
    spells: allSpells.filter(spell => spell.isEvil)
  }
  console.log(evilBook)
  return evilBook;
}

const MakeGoodSpellBook = (allSpells) => {
  let goodBook = {
    title: "Good Book",
    spells: allSpells.filter(spell => !spell.isEvil)
  }
  return goodBook;
}

const GetAllSpells = () => {
  return [
    {
      name: "Turn enemy into a newt",
      isEvil: true,
      energyReqired: 5.1
    },
    {
      name: "Conjure some gold for a local charity",
      isEvil: false,
      energyReqired: 2.99
    },
    {
      name: "Give a deaf person the ability to heal",
      isEvil: false,
      energyReqired: 12.2
    },
    {
      name: "Make yourself emperor of the universe",
      isEvil: true,
      energyReqired: 100.0
    },
    {
      name: "Convince your relatives your political views are correct",
      isEvil: false,
      energyReqired: 2921.5
    }
  ]
}



main();