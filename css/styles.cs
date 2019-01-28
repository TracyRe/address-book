/* ******** NON-MOBILE STYLES (*********) */
@media only screen and (min-width: 600px) {
  html {
    font-size: 16px;
  }

  .container-fluid {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    min-height: 100%;
  }

  div.content-wrapper {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 80%;
    padding: 20px 40px 40px 40px;
    margin: 20px auto 10px auto;
    border-radius: 8px;
    box-shadow: 4px 4px 10px rgba(100, 100, 100, 0.5);
  }

  // ********* FORM FIELDS AS LIST ITEMS **********

  // div.questions {
  //   display: flex;
  // }
  //
  // ul.flex-outer li {
  //   display: flex;
  //   flex-direction: row;
  //   flex-wrap: wrap;
  //   justify-content: center;
  //   align-items: center;
  //   margin-bottom: 10px;
  // }
  //
  // .flex-outer > li > label {
  //   flex: 1 0 120px;
  //   text-align: right;
  //   padding-right: 10px;
  // }
  //
  // .flex-outer > li > label + * {
  //   flex: 1 0 220px;
  //   min-width: 420px;
  //   text-align: left;
  // }

}

/* ******** MOBILE FIRST DEFAULT STYLES (*********) */

html {
  font-size: 24px;
}

body {
  background-color: #efece6;
}

label {
  font-weight: normal;
}


.container-fluid {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  min-height: 100%;
  padding: 0;
}

.container-fluid h1 {
  padding: 10px 20px 10px 20px;
}

.content-wrapper {
    width: 100%;
    height: 100%;
    padding: 20px;
    margin: 20px 0px 0px 0px;
}

.content-wrapper h2 {
  margin-top: 0px;
}


// ********* FORM FIELDS AS LIST ITEMS **********

// ul {
//   margin-left: -1em;
//   padding-right: 1em;
// }
//
// .flex-outer li {
//   display: flex;
//   flex-direction: column;
//   margin-bottom: 20px;
// }
//
// .flex-outer > li > label {
//   text-align: left;
// }
//
// .flex-outer > li > label + * {
// }

// ********** BUTTONS **********
//
// .button-row {
//   display: flex;
//   flex-direction: column;
//   justify-content: center;
//   align-items: center;
//   margin-top: 20px;
// }
//
// .btn-primary {
//   padding: 8px 20px 8px 20px;
//   text-transform: uppercase;
//   letter-spacing: .1em;
//   border-radius: 4px;
//   min-width: 150px;
// }

// ********** INPUT BORDER ON MOBILE ********
input, select {
  border: 1px solid #ccc;
  border-radius: 2px;
}

span.name {
  font-weight: bold;
}
