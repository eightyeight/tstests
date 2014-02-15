exec("tasman/main.cs");
Tasman.globals(true);

function onStart() {
   GlobalActionMap.bind("keyboard", "escape", "quit");
}

function onEnd() {
   Tasman.cleanUp();
}

function GameConnection::onEnterGame() {
   toggleConsole(true);
   Tasman.runAll();
}

//-----------------------------------------------------------------------------
// Unit tests! Test, for e.g., an object.

test(MyObject);

function MyObjectTests::before() {
   new ScriptObject(MyObject) {
      property = "value";
   };
}

function MyObjectTests::after() {
   MyObject.delete();
}

function MyObjectShould::exist() {
   expect(MyObject).toBeAnObject();
}

function MyObjectShould::have_a_property() {
   expect(MyObject.property).toEqual("value");
   expect(MyObject.property).toHave(1).word();
   expect(MyObject.property).not().toHave(4).words();
}

//-----------------------------------------------------------------------------
// Test a function.

test(adder);

function adder(%a, %b) {
   return %a + %b;
}

function adderShould::add_numbers() {
   expect(adder(1, 2)).toEqual(3);
}
