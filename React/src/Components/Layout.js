import { Link } from "react-router-dom";
import "./Layout.module.css";

const Layout = (props) => {
  return (
    <div>
      <nav>
        <Link to="/">Index</Link>
        <Link to="/teachers">Teachers</Link>
      </nav>
      {props.children}
    </div>
  )
};

export default Layout;