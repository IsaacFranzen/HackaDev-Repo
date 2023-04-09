import React from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./styles/globals.css";

import Home from "./pages/Home";
import About from "./pages/About";
import TransactionHistory from "./pages/TransactionHistory";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route exact path="/" element={<Home />} />
        <Route path="/about" element={<About />} />
        <Route path="/transiction" element={<Extract />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
