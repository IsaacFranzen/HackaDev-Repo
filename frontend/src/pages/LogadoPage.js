import React, { useState } from "react";
import Logado from "../components/areaLogada/Logado";
import { ReactComponent as Logo } from "../assets/svg/logo.svg";
import { ButtonDark } from "../components/Topbar/Topbar-styles";
import { BsMoonStars, BsSun } from "react-icons/bs";
import { ThemeProvider } from "styled-components";
import { darkTheme, lightTheme } from "../utils/theme";
import GlobalTheme from "../styles/globals.js";

const LogadoPage = () => {
  const [theme, setTheme] = useState("light");
  function alternarTheme() {
    setTheme(theme === "light" ? "dark" : "light");
  }

  return (
    <>
      <ThemeProvider theme={theme === "light" ? lightTheme : darkTheme}>
        <GlobalTheme />
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <Logo className="logo" alt={"Logo do nosso banco T&C BANKING"} />
          <ButtonDark className="theme-toggle" onClick={alternarTheme}>
            {theme === "light" ? <BsSun /> : <BsMoonStars />}
          </ButtonDark>
        </div>
        <Logado></Logado>
      </ThemeProvider>
    </>
  );
};

export default LogadoPage;
