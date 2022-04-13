import "../App.css";
import { useState, useEffect } from "react";

const Teachers = () => {
  const [teachers, setTeachers] = useState([]);

  const apiUrl = "http://localhost:17647/api/teachers";

  useEffect(() => {
    fetch(apiUrl)
      .then((response) => response.json())
      .then((data) => {
        console.log("My data? ", data);
        setTeachers((state) => data);
      });
  }, []);

  return (
    <div className="main-section">
      <h1>Teachers</h1>
      {teachers.map((element) => (
        <div>
          <h2>
            {element.firstName} {element.lastName}
          </h2>
        </div>
      ))}
    </div>
  );
};

export default Teachers;
