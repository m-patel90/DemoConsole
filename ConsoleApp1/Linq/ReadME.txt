WhereExpression() - Filter products using where. If the data is not found, an empty list is returned
WhereTwoFields() - Filter products using where with two fields. If the data is not found, an empty list is returned
WhereExtensionMethod() - Filter products using a custom extension method
Find() - Locate a specific product using the Find() method. NOTE: Find() only works on List<T> not IEnumerable<T>
First() - Locate a specific product using First(). First() searches forward in the collection. NOTE: First() throws an exception if the result does not produce any values
FirstOrDefault() - Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list. NOTE: FirstOrDefault() returns a null if no value is found
Last() - Locate a specific product using Last(). Last() searches from the end of the list backwards. NOTE: Last returns the last value from a collection, or throws an exception if no value is found
LastOrDefault() - Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards. NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
Single() - Locate a specific product using Single(). NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
SingleOrDefault() - Locate a specific product using SingleOrDefault(). NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.

ForEach() - ForEach allows you to iterate over a collection to perform assignments within each object.
ForEachCallingMethod() - Iterate over each object in the collection and call a method to set a property
Take() - Use Take() to select a specified number of items from the beginning of a collection
TakeWhile() - Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
Skip() - Use Skip() to move past a specified number of items from the beginning of a collection
SkipWhile() - Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
Distinct() - The Distinct() operator finds all unique values within a collection

All() - Use All() to see if all items in a collection meet a specified condition
Any() - Use Any() to see if at least one item in a collection meets a specified condition
LINQContains() - Use the LINQ Contains operator to see if a collection contains a specific value
LINQContainsUsingComparer() - Use the LINQ Contains operator to see if a collection contains a specific object using an EqualityComparer class to perform the comparison

SequenceEqualIntegers() - SequenceEqual() compares two different collections to see if they are equal
SequenceEqualProducts() - When using a collection of objects, SequenceEqual() performs a comparison to see if the two object references point to the same object
SequenceEqualUsingComparer() - Use an EqualityComparer class to determine if the objects are the same based on the values in properties
ExceptIntegers() - Except() finds all values in one list that are not in the other list
Except() - Except() finds all products in one list that are not in the other list using a comparer class
Intersect() - Intersect() finds all products that are in common between two collections using a comparer class
Union() - Union() combines two lists together, but skips duplicates by using a comparer class. This is like the UNION SQL operator.
LINQConcat() - The LINQ Concat() operator combines two lists together, but does NOT check for duplicates