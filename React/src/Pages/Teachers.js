import "../App.css";
import { useState, useEffect, useRef } from "react";
import Layout from "../Components/Layout";

const Teachers = () => {
  const [teachers, setTeachers] = useState([]);
  const [addTeacher, setAddTeacher] = useState(false);

  const apiUrl = "http://localhost:17647/api/teachers";

  useEffect(() => {
    fetch(apiUrl)
      .then((response) => response.json())
      .then((data) => {
        console.log("My data? ", data);
        setTeachers((state) => data);
      });
  }, [addTeacher]);

  const AddTeacherHandler = (event) => { 
    event.preventDefault();

    const data = {};
    const inputs = document.getElementsByTagName("input");

    for (let input of inputs) data[input.id] = input.value;
    console.log('data', data);

    const body = JSON.stringify({ 
      firstName: data["firstName"], 
      lastName: data["lastName"],
      departmentId: parseInt(data["department"])
    });

    console.log('body', body);

    const requestOptions = {
      method: "POST",
      body: body,
      headers: {
        "Content-Type": "application/json; charset=utf-8",
      }
    };
    fetch(apiUrl, requestOptions)
      .then(response => response.json())
      .then(data => {
        console.log("Data", data);
      })
      .finally(() => {
        setAddTeacher(false);
      });
  };

  const AddTeacherArea = () => {
    return (
      <div>
        <hr />
        <h1>Add Teacher</h1>
        <form onSubmit={AddTeacherHandler}>
          <input id="firstName" type="text" />
          <input id="lastName" type="text" />
          <input id="department" type="text" />
          <button type="submit">Add</button>
        </form>
      </div>
    );
  }

  return (
    <Layout>
      <div className="main-section">
        <h1>Teachers</h1>
        {teachers.map((element) => (
          <div>
            <h2>
              {element.firstName} {element.lastName}
            </h2>
          </div>
        ))}
        {!addTeacher && <button onClick={() => setAddTeacher(true)}>Add Teacher</button>}
        {addTeacher && AddTeacherArea()}
      </div>
    </Layout>
  );
};

export default Teachers;
