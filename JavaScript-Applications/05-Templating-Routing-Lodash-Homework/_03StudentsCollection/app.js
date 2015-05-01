(function() {
    var students = [
        {"gender":"Male","firstName":"Joe","lastName":"Riley","age":22,"country":"Russia"},
        {"gender":"Female","firstName":"Lois","lastName":"Morgan","age":41,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Roy","lastName":"Wood","age":33,"country":"Russia"},
        {"gender":"Female","firstName":"Diana","lastName":"Freeman","age":40,"country":"Argentina"},
        {"gender":"Female","firstName":"Bonnie","lastName":"Hunter","age":23,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Joe","lastName":"Young","age":16,"country":"Bulgaria"},
        {"gender":"Female","firstName":"Kathryn","lastName":"Murray","age":22,"country":"Indonesia"},
        {"gender":"Male","firstName":"Dennis","lastName":"Woods","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Billy","lastName":"Patterson","age":24,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Willie","lastName":"Gray","age":42,"country":"China"},
        {"gender":"Male","firstName":"Justin","lastName":"Lawson","age":38,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Ryan","lastName":"Foster","age":24,"country":"Indonesia"},
        {"gender":"Male","firstName":"Eugene","lastName":"Morris","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Eugene","lastName":"Rivera","age":45,"country":"Philippines"},
        {"gender":"Female","firstName":"Kathleen","lastName":"Hunter","age":28,"country":"Bulgaria"}];

    console.log('=======Students with age between 18 and 24:=======');
    var studentsByAge = _.filter(students, function(s) {
            return (s.age >= 18 && s.age <= 24);
        })
    .forEach(function(s) {
        console.log(s.firstName + ' ' + s.lastName + ', age: ' + s.age);
    });

    console.log('=======First name before last name:=======');
    var studentsByName = _.filter(students, function(s) {
            return s.firstName.localeCompare(s.lastName) < 0;
        })
    .forEach(function(s) {
        console.log(s.firstName + ' ' + s.lastName);
    });

    console.log('=======Students from Bulgaria:=======');
    var studentsByCountry = _.where(students, {"country": "Bulgaria"})
    .forEach(function(s) {
        console.log(s.firstName + ' ' + s.lastName + ' from ' + s.country);
    });

    console.log('=======Last 5:=======');
    var lastFive = _.takeRight(students, 5)
        .forEach(function(s) {
            console.log(s.firstName + ' ' + s.lastName);
        });

    console.log('=======First 3 Male from Bulgaria:=======');
    var firstThreeMaleBg = _.chain(students)
      .filter(function(s) {
          return s.country !== 'Bulgaria' && s.gender === 'Male';
      })
      .take(3)
      .value()
      .forEach(function(s) {
          console.log(s.firstName + ' ' + s.lastName + ', Country: ' + s.country + ', Gender: ' + s.gender);
      });

}());
