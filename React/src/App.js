import { Link } from "react-router-dom";
import Layout from "./Components/Layout";

const App = () => {
  return (
    <Layout>
      <h1>App boi</h1>
      <Link to="/teachers">Cool</Link>
    </Layout>
  );
};

export default App;
