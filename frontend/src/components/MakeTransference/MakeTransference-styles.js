import styled from "styled-components";

export const InputField = styled.div`
  position: relative;
  width: 100%;
  height: 50px;
  margin: 40px 0;

  label {
    position: absolute;
    left: 5px;
    top: 50%;
    transform: translateY(-50%);
    font-size: 1em;
    font-weight: 500;
    pointer-events: none;
    transition: 0.5s;
  }

  input:focus ~ label,
  input:valid ~ label {
    top: -8px;
  }

  input {
    width: 100%;
    height: 100%;
    border: 1px solid #8c8686;
    border-radius: 5px;
    outline: none;
    font-size: 1em;
    font-weight: 600;
    padding: 0 35px 0 5px;
  }

  input::-webkit-outer-spin-button,
  input::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0;
  }

  input[type=number] {
    -moz-appearance: textfield;
  }

  .validationError {
    padding-left: 5px;
    color: red;
    font-size: 0.7em;
  }

  .icon {
    position: absolute;
    right: 8px;
    font-size: 1.2em;
    color: #000;
    line-height: 57px;
  }
`

export const Button = styled.button`
  width: 100%;
  height: 45px;
  background: #7920be;
  border: none;
  outline: none;
  border-radius: 5px;
  cursor: pointer;
  font-size: 1em;
  color: #fff;
  font-weight: 500;

  :hover {
    background: #791ebede;
  }
`