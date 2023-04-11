import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "./styles/globals.js";

import Home from "./pages/Home";
import Cadastro from "./pages/Cadastro.js";

function App() {
  return (
    <>
      <Router>
        <Routes>
          <Route exact path="/" element={<Home />} />
          <Route path="/cadastro" element={<Cadastro />} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
