/* eslint-disable react/prop-types */
import React, { Fragment, useState } from "react";
import { Link } from "react-router-dom";
import GlobalTheme from "../../styles/globals.js";
import { ThemeProvider } from "styled-components";
import { ReactComponent as Logo } from "../../assets/svg/logo.svg";
import { lightTheme, darkTheme } from "../../utils/theme.js";
import { BsSun, BsMoonStars } from "react-icons/bs";
import { ButtonDark, Header, NavBar } from "./Topbar-styles.js";

const Topbar = () => {
  const [theme, setTheme] = useState("light");

  function alternarTheme() {
    setTheme(theme === "light" ? "dark" : "light");
  }

  return (
    <ThemeProvider theme={theme === "light" ? lightTheme : darkTheme}>
      <Fragment>
        <GlobalTheme />
        <Header>
          <a href="/">
            <Logo className="logo" alt={"Logo do nosso banco T&C BANKING"} />
          </a>
          <NavBar className="navegacao">

            <a href="/">Inicio</a>
            <a href="/area-logada">Login</a>
            <ButtonDark className="theme-toggle" onClick={alternarTheme}>
              {theme === "light" ? <BsSun /> : <BsMoonStars />}
            </ButtonDark>
          </NavBar>
        </Header>
      </Fragment>
    </ThemeProvider>
  );
};

export default Topbar;
