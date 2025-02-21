import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Home } from "./pages/Home";
import { Dashboard } from "./pages/Dashboard";
import { Advertisers } from "./pages/Advertisers";
import { Games } from "./pages/Games";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/advertisers" element={<Advertisers />} />
        <Route path="/games" element={<Games />} />
      </Routes>
    </Router>
  );
}

export default App;
