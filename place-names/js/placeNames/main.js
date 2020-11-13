function main() {
  // Put your code here
  const names = ["Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

  console.log("All Place Names")
  for (place of names) {
    console.log(place)
  }

  console.log("")

  let theNames = names.filter(name => name.startsWith("The"))


  console.log("'The' Place Names")
  for (place of theNames) {
    console.log(place)
  }
}

main();