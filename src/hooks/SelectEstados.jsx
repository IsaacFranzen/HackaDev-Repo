/* eslint-disable react/prop-types */
import React from "react";
import { useEffect } from "react";
import { fetchEstados } from "../helpers/ibge";
import { useState } from "react";
import { SelectDados } from "../components/AllTabs/StylesAbas-styles";

const SelectEstados = ({ id, name, onChange = () => {} }) => {
  const [states, SetStates] = useState([]);
  useEffect(() => {
    fetchEstados().then((states) => {
      SetStates(states);
    });
  }, []);
  return (
    <SelectDados
      id={id || name}
      name={name || id}
      onChange={onChange}
      style={{ width: "100%" }}
    >
      <option value="">Selecione um estado...</option>

      {states.map((state) => {
        {
          const { sigla, nome } = state;
          return (
            <option key={sigla} value={sigla}>
              {nome}
            </option>
          );
        }
      })}
    </SelectDados>
  );
};

export default SelectEstados;
