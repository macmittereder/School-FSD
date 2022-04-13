import { Fragment } from "react";
import { Route, Routes, Navigate } from "react-router-dom";
import Index from "./Pages/Index";
import Teachers from "./Pages/Teachers";

const App = () => {
  return (
    <Fragment>
      <h1>Test</h1>
      <Routes>
        <Route path="/" exact>
          <Navigate to="/index" />
        </Route>
        <Route path="/index" exact>
          <Index />
        </Route>
        <Route path="/teachers">
          <Teachers />
        </Route>
      </Routes>
    </Fragment>
  );
};

export default App;
