# MudAutocompleteBindingDemo
A demo of wrapping MudAutocomplete to bind directly to an integer key value

I wanted to use MudAutocomplete as a "ComboBox" type control to return a key value. Since I have dozens (if not hundreds) of individual fields in apps, it also saves a lot of time and code to set repeated options in a wrapper component.

Took me a bit to get the binding to work the way I want, and using a generic class was just not worth the effort (particulary around type-casting back to the Generic and looking up values by field name by reflection), so I just decided to use the use case that works for me, a two-field object, with an int ID (key) and a string Text (value).

Does what I need it to.

Live demo at https://autocompletedemo1bph.azurewebsites.net
