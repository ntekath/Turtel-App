import React from "react";
import Svg, { G, Path, Defs, ClipPath } from "react-native-svg"

function Camera() {
  return (
    <Svg
      xmlns="http://www.w3.org/2000/svg"
      width="30"
      height="30"
      fill="none"
      viewBox="0 0 18 16"
    >
      <Path
        fill="#9679C1"
        d="M15.667 2.333h-2.642L11.5.667h-5L4.975 2.333H2.333C1.417 2.333.667 3.083.667 4v10c0 .917.75 1.667 1.666 1.667h13.334c.916 0 1.666-.75 1.666-1.667V4c0-.917-.75-1.667-1.666-1.667zm0 11.667H2.333V4h3.375l1.525-1.667h3.534L12.292 4h3.375v10zM9 4.833A4.168 4.168 0 004.833 9c0 2.3 1.867 4.167 4.167 4.167S13.167 11.3 13.167 9 11.3 4.833 9 4.833zM9 11.5A2.507 2.507 0 016.5 9c0-1.375 1.125-2.5 2.5-2.5s2.5 1.125 2.5 2.5-1.125 2.5-2.5 2.5z"
      ></Path>
    </Svg>
  );
}

export default Camera;
